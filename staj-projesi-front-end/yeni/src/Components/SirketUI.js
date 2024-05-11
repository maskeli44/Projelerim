import React, { Component } from 'react'
import PropTypes from 'prop-types'
import YeniSirketKayit from './YeniSirketKayit';
 class SirketUI extends Component {
     uyari="! Eğer Listede Şirketiniz Yok sa Yeni Kayıt Butonuna Basın Aksi Halde İşleminize Devam Edebilirsiniz!";
    static defaultProps={
        name: 'bilgiyok',
    }
    constructor(props){
       super(props);
       
    }
  render() {
    const deplisteleme=['asd','al','götür'];
    const sirlisteleme=['Aselsan','Havelsan','Harran Üniversitesi'];
    const {name}= this.props;
    function Listeler(liste){
        const sonListe=[] 
        liste.forEach(element => {
            sonListe.push(<option key={element}>{element}</option>)
        });
        return(sonListe)
    }
    return (
        
    <div className='col-6 '  >
      <div className='container' style={{marginTop:'10px', backgroundColor:'lightgray'}}> 
        <div className="row g-3">
            <div className="col-md-6">
                <label htmlFor="inputState" className="form-label">Şirket Adı</label>
                <select id="inputState" className="form-select" defaultValue={0}>
                    <option >Seçiniz...</option>
                    {
                        Listeler(sirlisteleme)
                    }
                </select>
            </div>
            <div className="col-md-6">
                <label htmlFor="inputState" className="form-label">Departman Adı</label>
                <select id="inputState" className="form-select" defaultValue={0}>
                    <option >Seçiniz...</option>
                    {
                        Listeler(deplisteleme)
                    }  
                </select>
            </div>
            
        </div>
        <div className='row g-3' style={{marginTop: '1px'}}>
            <div className='col'>
                {this.uyari}      
            </div>
            
            
        </div>
        <div className='row g-3' style={{marginTop: '1px'}}>
            <div className='col' style={{marginBottom:'5px'}}>
                <YeniSirketKayit/>
            </div>
            
        </div>
      </div>
      </div>
    )
  }
}

export default SirketUI;