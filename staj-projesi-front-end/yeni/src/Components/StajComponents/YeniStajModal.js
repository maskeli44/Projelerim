
import React, { Component } from 'react'
import uuid from 'react-uuid';
import UserConsumer from '../../Context';
import axios from 'axios';

export default class YeniStajModal extends Component {
   
    state={
      
      sirketIsim:'', departmanIsim:'',stajAmiri:'',stajGunSayisi:'',stajBaslamaTarihi:'',stajBitisTarihi:'',adres:'',muhSayi:'',
    }
    changeInput = (e)=>{
      
      this.setState({
        [e.target.id]:[e.target.value],
      })
      
    }
    addStaj = (e)=>{
      e.preventDefault();
      
      const yeniStaj ={
          company_name:this.state.sirketIsim.textarea,
          sector:this.state.departmanIsim.textarea,
          internship_supervisor:this.state.stajAmiri.textarea,
          internship_day_count:this.state.stajGunSayisi.textarea,
          internship_start_date:this.state.stajBaslamaTarihi.textarea,
          internship_finish_date:this.state.stajBitisTarihi.textarea,
          address:this.state.adres.textarea,
          muhSayi:this.state.muhSayi.textarea,
      }
      axios.post('http://localhost:8080/addInternship', yeniStaj)
              .then((res) => {
                  console.log(res.data)
              }).catch((error) => {
                  console.log(error)
              });
          this.setState({ company_name:'',
            sector:'',
            tax_number:'',
            phone_no:'',
            email:'',
            web_address:'',
            address:'' })
      console.log('test');
      
            
    }
    
    render(){
      var {sirketIsim, departmanIsim,stajAmiri,stajGunSayisi,stajBaslamaTarihi,stajBitisTarihi,adres,muhSayi}= this.state;
      return(
      <UserConsumer>
        {
          value=>{
            var {sirketTableData}=value;
            if(value.bal.sirketTableData!==undefined)
              sirketTableData= value.bal.sirketTableData;
            else if(value.bal.rows!==undefined)
              sirketTableData.rows=value.bal.rows;
              
            const deplisteleme=sirketTableData.rows.map(function(row){return(row.sector)});
            
            const sirlisteleme=sirketTableData.rows.map(function(row){return(row.company_name)});;
            function Listeler(liste){
                
                const sonListe=[] 
                liste.forEach(element => {
                    sonListe.push(<option key={uuid()} value={element}>{element}</option>)
                });
                return(sonListe)
            }
            return(
          
              <div>
                <button
                  type="button"
                  className="btn btn-success"
                  data-bs-toggle="modal"
                  data-bs-target="#exampleModal"
                >
                  Yeni Staj Başvurusu
                </button>
                {/* Modal */}
                <form onSubmit={this.addStaj}>
                <div
                  className="modal fade"
                  id="exampleModal"
                  tabIndex={-1}
                  aria-labelledby="exampleModalLabel"
                  aria-hidden="true"
                >
                  <div className="modal-dialog">
                    <div className="modal-content">
                      <div className="modal-header">
                        <h5 className="modal-title" id="exampleModalLabel">
                          Yeni Staj Başvurusu
                        </h5>
                        <button
                          type="button"
                          className="btn-close"
                          data-bs-dismiss="modal"
                          aria-label="Close"
                        />
                      </div>
                      <div className="modal-body">
                          <div className="input-group mb-3">
                              
                              <select id="inputState" className="form-select " defaultValue={0} aria-label={sirketIsim} >
                                  <option >Şireket Seçiniz...</option>
                                  {
                                      Listeler(sirlisteleme)
                                  }
                              </select>
                              <span className="input-group-text">  </span>
                              <select id="inputState" className="form-select" defaultValue={0} aria-label={departmanIsim} >
                                  <option >Departman Seçiniz...</option>
                                  {
                                      Listeler(deplisteleme)
                                  }  
                              </select>
                          </div>
                            <div className="input-group mb-3">
                              <input
                                type="text"
                                className="form-control"
                                placeholder="Staj Amiri"
                                aria-label="stajAmiri"
                                value={stajAmiri}
                                onChange={this.changeInput}
                              />
                              <span className="input-group-text">  </span>
                              <input
                                type="text"
                                className="form-control"
                                placeholder="Yapılacak Staj Gün Sayisi"
                                aria-label="stajGunSayisi"
                                value={stajGunSayisi}
                                onChange={this.changeInput}
                              />
                            </div>
                            <div className="input-group mb-3">
                              <input
                                type="text"
                                className="form-control"
                                placeholder="Staj Başlama Tarihi"
                                aria-label="stajBaslamaTarihi"
                                value={stajBaslamaTarihi}
                                onChange={this.changeInput}
                              />
                              <span className="input-group-text">  </span>
                              <input
                                type="text"
                                className="form-control"
                                placeholder="Staj Bitiş Tarihi"
                                aria-label="stajBitisTarihi"
                                value={stajBitisTarihi}
                                onChange={this.changeInput}
                              />
                            </div>
                            <div className="input-group mb-3">
                                <textarea
                                  className="form-control"
                                  aria-label="adres"
                                  placeholder="Stajda Yapılması Planlanan Konu"
                                  value={adres}
                                  onChange={this.changeInput}
                              />
                            </div>
                            <div className="input-group mb-3">
                                <input
                                  type="text"
                                  className="form-control"
                                  placeholder="Departmandaki Mühendis Sayısı"
                                  aria-label="muhSayi"
                                  id='muhSayi'
                                  value={muhSayi}
                                  onChange={this.changeInput}
                                />
                                
                              </div>
              
                      </div>
                      <div className="modal-footer">
                        <button
                          type="button"
                          className="btn btn-secondary"
                          data-bs-dismiss="modal"
                        >
                          Kapat
                        </button>
                        <button type="button" className="btn btn-primary">
                          Kayıt
                        </button>
                      </div>
                    </div>
                  </div>
                </div>
                </form>
              </div>
            )
          }
        }
      </UserConsumer>
      )
    }
  
    
  
}
