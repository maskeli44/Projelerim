import axios from 'axios'
import React, { Component } from 'react'


export default class YeniSirketKayit extends Component{
  state={
    sirketIsim:'',
    sektor:'',
    vergiNumarasi:'',
    telefonNumarası:'',
    email:'',
    webAdres:'',
    adres:'',
  }


  changeInput = (e)=>{
    this.setState({
      [e.target.id]:[e.target.value],
    })
    
  }
  addSirket = (e)=>{
    e.preventDefault();
    
    const yeniSirket ={
        company_name:this.state.sirketIsim.toString(),
        sector:this.state.sektor.toString(),
        tax_number:this.state.vergiNumarasi.toString(),
        phone_no:this.state.telefonNumarası.toString(),
        email:this.state.email.toString(),
        web_address:this.state.webAdres.toString(),
        address:this.state.adres.toString()
    }
    console.log(yeniSirket);
    axios.post('http://localhost:8080/addCompany', yeniSirket)
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
    var {sirketIsim, sektor,vergiNumarasi,telefonNumarası,email,webAdres,adres,}= this.state;
    
    return(
        <div>
          <button
      type="button"
      className="btn btn-success"
      data-bs-toggle="modal"
      data-bs-target="#exampleModal"
    >
      Yeni Kayıt
    </button>
    {/* Modal */}
    <form onSubmit={this.addSirket}>
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
              Yeni Şirket Kaydetme
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
                  <input
                    type="text"
                    className="form-control "
                    placeholder="Şirket İsmi"
                    aria-label="sirketIsim"
                    id='sirketIsim'
                    name='sirketIsim'
                    value={sirketIsim}
                    onChange={this.changeInput}
                  />
                  <span className="input-group-text">  </span>
                  <input
                    type="text"
                    className="form-control"
                    placeholder="Sektör"
                    aria-label="sektor"
                    id='sektor'
                    value={sektor}
                    onChange={this.changeInput}
                  />
                </div>
                <div className="input-group mb-3">
                  <input
                    type="text"
                    className="form-control"
                    placeholder="Vergi Numarası"
                    aria-label="vergiNumarasi"
                    id='vergiNumarasi'
                    value={vergiNumarasi}
                    onChange={this.changeInput}
                  />
                  <span className="input-group-text">  </span>
                  <input
                    type="text"
                    className="form-control"
                    placeholder="Telefon Numarası"
                    aria-label="telefonNumarası"
                    id='telefonNumarası'
                    value={telefonNumarası}
                    onChange={this.changeInput}
                  />
                </div>
                <div className="input-group mb-3">
                  <input
                    type="text"
                    className="form-control"
                    placeholder="E-posta"
                    aria-label="email"
                    id='email'
                    value={email}
                    onChange={this.changeInput}
                  />
                  <span className="input-group-text">  </span>
                  <input
                    type="text"
                    className="form-control"
                    placeholder="Web Adresi"
                    aria-label="webAdres"
                    id='webAdres'
                    value={webAdres}
                    onChange={this.changeInput}
                  />
                </div>
                <div className="input-group mb-3">
                    <span className="input-group-text">Adres</span>
                    <textarea
                      className="form-control"
                      aria-label="adres"
                      id='adres'
                      value={adres}
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
            <button type="submit" className="btn btn-primary" >
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
