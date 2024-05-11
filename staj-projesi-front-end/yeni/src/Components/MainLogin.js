
import React, { Component } from 'react'
import TeacherUserLogin from './TeacherUserLogin'
import StudentUserLogin from './StudentUserLogin'


class MainLogin extends Component {
constructor(props){
  super(props);
  
}

  render() {
    const props= this.props;
    return (
      <div className='col'>
        <form className="p-3 mb-2 bg-primary text-white">
        <div className="conteiner" >
        <button className="col-md-10 offset-md-1" name='button1' id='button1'onClick={(e)=>props.handlePageChange('TeacherUserLogin')}>
          öğretim Görevlisi Giriş
        </button>
        <button  className="col-md-10 offset-md-1" name='button2' onClick={(e)=>props.handlePageChange('StudentUserLogin')}>

          Öğrenci Giriş
        </button>
        
      </div>
      </form>
      </div>
      
    )
  }}
 export default  MainLogin;
