import React, { Component, useState } from 'react'
import UserConsumer from '../Context';
import uuid from 'react-uuid';
import Popup from './Popup';
import axios from 'axios';

 class TeacherPage extends Component {
    constructor(props){
        super(props);
        this.state={
          TeacherTableData : {
            columns: ['Student_no','Name','Days','company_name'],
            showColumns:['Öğrenci No','ADI SOYADI','Yapacağı GÜN Sayıs','Şirket Adı'],
            rows:[ ],
          }
      }
     
      /*ogrenci =()=>{

      }*/
      }
      componentDidMount = async () =>{
        const responseURL="http://localhost:8080";
        const response=await  axios.get(responseURL+"/Detay");
        const jsonstring= JSON.stringify(response.data);
        const data = JSON.parse(jsonstring);
        this.setState({
          
          TeacherTableData : {
            columns: ['Student_no','Name','Days','company_name'],
            showColumns:['Öğrenci No','ADI SOYADI','Yapacağı GÜN Sayıs','Şirket Adı'],
            rows:data,
          }
        })
          
      }
    
      
       
  render() {  
    const[openPopup,setOpenPopup]=useState(false)
    return (
      <UserConsumer>
      {
        value=>{
          const {TeacherTableData} =value;
          var dataShowColumns=TeacherTableData.showColumns;
          var dataColumns = TeacherTableData.columns;
          var dataRows =  TeacherTableData.rows;
          
          var tableHeaders = (
              <tr>
                {dataShowColumns.map(function(column) {
                  return <th style={{width: '500px',height:'auto',"borderWidth":"1px", 'borderColor':"#aaaaaa", 'borderStyle':'solid',}} key={uuid()}>{column}</th>; })}
              </tr>
          );

          var tableBody = dataRows.map(function(row) {

              return (
                <tr key={uuid()}>
                  {dataColumns.map(function(column) {
                    return <td key={uuid()} style={{width:'auto',"borderWidth":"1px", 'borderColor':"#aaaaaa", 'borderStyle':'solid',}}>
                      {row[column]}
                      <button onClick={()=>setOpenPopup(true)}
                       style={{width:'auto',"borderWidth":"1px",
                        'borderColor':"#aaaaaa", 'borderStyle':'solid',}} >
                        Detay
                      </button>
                      
                      </td>; })}
                </tr>
                

                ); });
           return (
              <div className='table col'>
                <table style={{"borderWidth":"1px", 'borderColor':"#aaaaaa", 'borderStyle':'solid', 'marginTop':'15px'}} className="table table-bordered table-hover" width="100%">
                    <thead>
                        {tableHeaders}
                    </thead>
                    <tbody style={{width: 'auto',height:'auto',"borderWidth":"1px", 'borderColor':"#aaaaaa", 'borderStyle':'solid',}}>
                    
                    {tableBody}
                    </tbody>
                </table>
              </div>
            

            )
            
        }
      }
      <Popup openPopup ={openPopup}
      setOpenPopup={setOpenPopup}>
     <TeacherPage/> 
      </Popup>
    </UserConsumer>
    )
  }
}export default TeacherPage;
