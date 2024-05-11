
import React, { Component } from 'react'
import uuid from 'react-uuid';
import YeniSirketKayit from './YeniSirketKayit';
import UserConsumer from '../../Context';


export default class SirketUI2 extends Component {
    uyari="! Eğer Listede Şirketiniz Yok sa Yeni Kayıt Butonuna Basın Aksi Halde İşleminize Devam Edebilirsiniz!";
    constructor(props){
      super(props);
      this.state={
        dispatch:{},
        filteredSirketName:'',
      }
    }
   changeInput = async(dispatch,e)=>{
    try {
      if(e!==undefined){
        this.setState({
          [e.target.id]:[e.target.value],
        })
        await dispatch({type:'showCompany',payload:[e.target.value]})
      }
      
      else{
        await dispatch({type:'showCompany',payload:this.state.filteredSirketName});
      }
    } catch (error) {
      console.log(error);
    }
    
      
  }
  componentDidMount=(e)=> { 
    this.changeInput(this.state.dispatch,undefined)
   }
  render() {
    var state = this.state;
    return(
      <UserConsumer>
        {
          value=>{
            
            const {sirketTableData} =value;
           
            state.dispatch=value.dispatch;
            var {filteredSirketName}=this.state;
            var dataShowColumns=sirketTableData.showColumns;
            var dataColumns = sirketTableData.columns;
            
            var dataRows=[];
               
            if(value.bal.sirketTableData!==undefined)
              dataRows= value.bal.sirketTableData.rows;
            else if(value.bal.rows!==undefined)
              dataRows=value.bal.rows;
            else{
              dataRows = sirketTableData.rows;
            }
            
            //console.log(dataRows);
            value.mountYonlendirici='SirketleriGetir';
            var tableHeaders = (
                <tr className=''>
                  {dataShowColumns.map(function(column) {
                    return <th style={{width: '500px',height:'auto',"borderWidth":"1px", 'borderColor':"#aaaaaa", 'borderStyle':'solid',}} key={uuid()}>{column}</th>; })}
                </tr>
            );

            var tableBody = dataRows.map(function(row) {

                return (
                  <tr key={uuid()} className="page-item">
                    {dataColumns.map(function(column) {
                      return <td key={uuid()} style={{width:'auto',"borderWidth":"1px", 'borderColor':"#aaaaaa", 'borderStyle':'solid',}}>{row[column]}</td>; })}
                  </tr>); 
            });

            return (
              <div className='table col'>
                  <br/>
                  <div className=''><input id='filteredSirketName' placeholder='Arama Yapın' value={filteredSirketName} onChange={this.changeInput.bind(this,value.dispatch)} className="text-center md-6 form-control pagination" /></div>
                  
                  <table style={{"borderWidth":"1px", 'borderColor':"#aaaaaa", 'borderStyle':'solid', 'marginTop':'15px'}} className="datatable table table-bordered table-hover" width="100%">
                      <thead>
                          {tableHeaders}
                      </thead>
                      <tbody style={{width: 'auto',height:'auto',"borderWidth":"1px", 'borderColor':"#aaaaaa", 'borderStyle':'solid',}} className="">
                      
                      {tableBody}
                      </tbody>
                  </table>
                  {
                      this.uyari
                  }
                  <YeniSirketKayit/>
              </div>

            )
          }
        }
      </UserConsumer>
    )
   
  }
}
