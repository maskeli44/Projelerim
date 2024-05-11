import { isVisible } from '@testing-library/user-event/dist/utils'
import React, { Component } from 'react'
import UserConsumer from '../Context';
import axios from 'axios'



 class StudentUserLogin extends Component {
  constructor(props){
    super(props);
   // isVisible:true;
   this.state={
    user:'',
    password:'',
  }
  }
  onGiris=(user,password,dispatch,e)=>{
    try{
      if(user!==''&&password!==''){
        axios.get("http://localhost:8080/student/"+ user)
        .then((res) => {
            if(res.data!==[]){
              res.data.map(function(column)
              {
                return(dispatch({type:'studentIdGet',payload:column.id}))
              });
              this.props.handlePageChange('AnaSayfa')
            }
            
        }).catch((error) => {
            console.log(error)
        });
        
      }
    }catch(a){
      console.log(a);
    }
    
      
      
  }
  
  changeInput = (e)=>{
    this.setState({
      [e.target.id]:[e.target.value],
    })
    
  }
  
   
  
  render() {
    const props= this.props;
    var {user}= this.state;
    var {password}=this.state;
    
    return (
      <UserConsumer>
        {value=>{
          
          var {dispatch}=value;
          return(
            <div className="StudentUserLogin col">
            <form className="p-3 mb-2 bg-primary text-white" onSubmit={(e)=>{e.preventDefault()}}>
             
            <div className="conteiner">
            <div className="row">
            <h1  className="col-md-8%3 offset-md+1" > Öğrenci Giriş Sayfası</h1>
            <div className="label">
         
                <label  className="form-label" >Öğrenci Numarası</label>
                    <input type="value" 
                    id="user" 
                     className="col-md-8%3 offset-md" 
                    autoComplete='off'
                    value={user}
                    onChange={this.changeInput}
                    required
                    />
                  
              </div>
                    <div className="col-md-5 offset-md-4" >
                      <label className="form-label">Şifre</label>
                          <input type="password" 
                              id="password"
                              onChange={this.changeInput}
                              value={password}
                              required 
                                 />
                                   </div>
                          <div id="passwordHelpBlock" 
                          className="col-md-8 offset-md-3" 
                          style={{color:"red"}}>
                          Şifreniz en az 8 karakter uzunluğunda olmalı, harf ve rakamlardan oluşmalı,özel karakter veya emoji içermemelidir.
                          </div>  
                            
                            <button   
                             className="col-md-2 offset-md-5 bg-danger text-white" onClick={this.onGiris.bind(this,user,password,dispatch)}
                             >
                               Giriş
                                </button>
            </div>
            </div>
            </form>
            
          </div>
          )
          
        }}
      </UserConsumer>
      
    )
  }
}
export default StudentUserLogin;