import React, { Component } from 'react'
import uuid from 'react-uuid'
import UserConsumer from '../../Context'

export default class StajCard extends Component {
    constructor(props){
        super(props)
        this.state={
            _isVisible:false,
        }
    }
    onClickEvent=(e)=>{
    
        this.setState({
          _isVisible: !this.state._isVisible,
        })
      }
  render() {
    const {staj}=this.props;
    const {_isVisible}=this.state;
    const tarih=new Date();
    return (
        
        <div className="card " style={{  }} key={uuid()} >
        <div className="card-header" ><h4 onClick={this.onClickEvent}>{tarih.getFullYear(staj.start_date) } Dönemi Stajı</h4></div>
        {
            _isVisible ? 
            <div className='card-body '>
                <div className='row '>
                  
                  <div className='col'>Stajın Konusu: {staj.subject}</div>
                  <div className='col'>Stajın Başlangıç Tarihi: { staj.start_date}</div>
                  <div className='col'>Stajın Bitiş Tarihi:{staj.end_date}</div>
                </div>
                <div className='row'>
                  <div className='col'>Stajın Gün Sayısı:{staj.number_of_days}</div>
                  <div className='col'>Komisyon Onayı:
                    
                    <input
                      className="form-check-input"
                      type="checkbox"
                      defaultValue=""
                      id="flexCheckDisabled"
                      defaultChecked={staj.commission_approval}
                      disabled
                    />
                      
                  </div>
                  <div className='col'>Kabul Edilen Gün Sayısı:{staj.accepted_number_of_days}</div>
                </div>
            </div>
            : null 
        }
        </div>
        
    )
  }
}
