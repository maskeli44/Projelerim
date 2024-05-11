
import React, { Component } from 'react';
import uuid from 'react-uuid';
import UserConsumer from '../../Context';
import StajCard from './StajCard';
import YeniStajModal from './YeniStajModal';

export default class StajBilgiEkrani extends Component {
  constructor(props){
    super(props);
    this.state={
      isVisible: false,
      butonGecerliMi: true,
      stajlar:[],
      ogrenci:{},
      dispatch:{},
    }
   
  }
 
  onButonEvent=(e)=>{
    this.setState({
      butonGecerliMi: !this.state.butonGecerliMi,
    })
  }
  tarihKontrol=(e)=>{
    try {
      
    } catch (error) {
      console.log(error);
    }
  } 

  componentDidMount = async(e)=>{
    try {
      const {dispatch}=this.state;
      const ogrenciID=this.state.ogrenci.id;
      //await this.onStajlar(ogrenciID);
      dispatch({type:'showIntership',payload:ogrenciID});
      //console.log(this.state.stajlar);
    } catch (error) {
      console.log(error);
    }
  }
  render() {
    try {
      var state= this.state;
      
      return(
        <UserConsumer>
          {
            value=>{
                
                state.ogrenci=value.ogrenci;
                state.dispatch=value.dispatch;
                var {stajlar}=this.state;
                if(value.bal.data!==undefined){
                  value.stajlar=value.bal.data;
                  stajlar=value.stajlar;
                }
                value.mountYonlendirici= 'StajlariGetir';
                var stajlariGoster=()=>{
                  const staj=[];
                  staj.push(stajCard)
                  return staj;
                }
                    
                var stajCard=stajlar.map(function(staj){
                    
                    return(
                      <StajCard staj={staj} key={uuid()}></StajCard>
                    );
                  });
                  
                
                  
              return (
                    <div className='col'>
                    <h4 >Staj Listesi</h4>
                    <div >
                        {stajlariGoster() }
                    </div>
                        <br/>
                        <br/>
                        <br/>
                    <div className=''>
                        { state.butonGecerliMi ? <YeniStajModal/> : null}
                        
                    </div>
                    
                  </div>
              );
              
            }
          }
        </UserConsumer>
      )
    
    } catch (error) {
      return(console.log(error))
      
    }
    
    
  }
}
