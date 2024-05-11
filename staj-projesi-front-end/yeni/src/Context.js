import axios from 'axios';
import React, { Component } from 'react'
const responseURL="http://localhost:8080";
const UserContext = React.createContext();
const reducer=async(state,action)=>{
  switch(action.type){
    case 'showCompany':
     { 
      
        const response=await  axios.get(responseURL+"/showCompany");
      const jsonstring= JSON.stringify(response.data);
      const data = JSON.parse(jsonstring);
      //const {rows}= state.sirketTableData;
      var sonData={}
      if(action.payload!=='')
        sonData= data.filter(row=>row.company_name.toLowerCase().indexOf(action.payload)>-1||row.sector.toLowerCase().indexOf(action.payload)>-1||row.email.toLowerCase().indexOf(action.payload)>-1);
      else
        sonData=data;
      //state.sirketTableData.rows=asd;
      return{...state.sirketTableData,
        rows:sonData
      }
    }
    case 'studentIdGet':{
      try{
        state.ogrenci.id= action.payload;
        return{...state,state}
      }
      catch(e){
        return console.log('context hata: '+e);
      }
      
    }
    case 'showIntership':{
      try{
        const ogrenciID=action.payload;
        const response=await axios.get(responseURL+"/getStudentApplication/"+ogrenciID);
        
        const jsonstring= JSON.stringify(response.data);
        const data = JSON.parse(jsonstring);
        return {...state.stajlar,data};
      }catch(e){
        return console.log("hata :"+e);
      }
    }
    case 'getStudentInfo':{
      try {
        const ogrenciID= action.payload;
        const response=await axios.get(responseURL+"/studentById/"+ogrenciID);
        
        const jsonstring= JSON.stringify(response.data);
        const data = JSON.parse(jsonstring);
        return {...state,state}
      } catch (error) {
        return console.log("hata :"+error);
      }
    }

    default:{
      return state;
    }
      

  }
}

export  class Context extends Component {
  
   state={
      sirketTableData : {
        columns: ['company_name','sector','email'],
        showColumns:['Şirket','Sektör','E-mail'],
        rows:[ ]
      },
      stajlar:[]
      ,
      ogrenci:{
        id:'',
        data:{},
      },
      dispatch: action=> {
        this.setState(state=>{reducer(state,action).then((value)=>{this.setState({bal:value})});});
      },
   }  
  
  render() {
    
    return (
      <UserContext.Provider value={this.state}>
        {this.props.children}
      </UserContext.Provider>
    )
  }
}

const UserConsumer = UserContext.Consumer;

export default UserConsumer;