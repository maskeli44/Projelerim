import React, { Component } from 'react'



class TeacherUserLogin extends Component {
  constructor(props){
    super(props);
    this.state={
      user:"",
      password:""
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
    function GirisYap(){
      if(user!==''&&password!==''){
        props.handlePageChange('TeacherPage')
      }}
    return (
      
        <div className="TeacherUserLogin col">
        <form  className="p-3 mb-2 bg-primary text-white">
        <div>
        <h1 className="col-md-5 offset-md-4">
           Eğitim Görevlisi Giriş Sayfası
           </h1>
        <div className="col-md-4 offset-md-4">
         <label className="form-label">
          sicil Numarası
          </label>
       <input type="value"
        id="user"
        value={user}
        autoComplete='off' 
        onChange={this.changeInput}
         required
         />
       <div className="col-md-8 offset-md-3" >
       <label className="form-label">
        Şifre    
        </label>
        <input type="password" 
          id="password"
           onChange={this.changeInput}
           value={password}
            required 
              />
        </div>
        <div id="passwordHelpBlock" 
        className="col-md-12 offset-md-3" 
        style={{color:"red"}}>
       Şifreniz en az 8 karakter uzunluğunda olmalı, harf ve rakamlardan oluşmalı,özel karakter veya emoji içermemelidir.
  </div>  
  
        <div className="col-md-8 offset-md-4" >
        <button   
          className="col-md-4 offset-md-5 bg-danger text-white"
          onClick={GirisYap}
                  >
               Giriş
           </button>
          </div>
        </div>
        </div>
        </form>
      </div>
     
    )
  }
}
export default TeacherUserLogin;