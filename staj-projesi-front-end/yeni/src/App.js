import React from 'react';
import './App.css';
import AnaSayfa from './Components/AnaSayfa';
import Navbar from './Components/Menu/Navbar';
import SideBar from './Components/Menu/SideBar';
import SirketUI from './Components/SirketComponents/SirketUI2';
import StajBilgiEkrani from './Components/StajComponents/StajBilgiEkrani';
import MainLogin from './Components/MainLogin';
import StudentUserLogin from './Components/StudentUserLogin';
import TeacherUserLogin from './Components/TeacherUserLogin';
//import TeacherPage from './Components/TeacherPage';

class App extends React.Component {
  constructor(props){
    super(props);
    this.state={
      activePage:'StudentUserLogin'
    } 
}
  handlePageChange = (activePage) => {
    this.setState({activePage: activePage})
  }
 render(){
  const {activePage}=this.state;
  return (
    <div className="App">
      <div className='row '>
      <Navbar/>
      </div>
      <div className='row  ' style={{height:'100vh'}} >
        {activePage==='MainLogin'&&<MainLogin handlePageChange={this.handlePageChange}/>}
        {activePage==='StudentUserLogin'&&<StudentUserLogin handlePageChange={this.handlePageChange}/>}
        {activePage==='TeacherUserLogin'&&<TeacherUserLogin handlePageChange={this.handlePageChange}/>}
        {activePage!=='MainLogin'&&activePage!=='StudentUserLogin'&&activePage!=='TeacherUserLogin'&& <SideBar handlePageChange={this.handlePageChange}/>}
        {activePage=== 'AnaSayfa'&&<AnaSayfa handlePageChange={this.handlePageChange}/>}
        {activePage=== 'SirketUI'&&<SirketUI handlePageChange={this.handlePageChange}/>}
        {activePage=== 'StajBilgiEkrani'&&<StajBilgiEkrani handlePageChange={this.handlePageChange} />}
        {/*activePage=== 'TeacherPage'&&<TeacherPage handlePageChange={this.handlePageChange} />*/}
        
      </div>
      <footer className='row-auto fixed-bottom' style={{backgroundColor:'#121E2D',color:'white'}}>Harran Üniversitesi</footer>
    </div>
  );
 }
  
}

/*
<SirketUI title="new"/>

*/
/*
<div className='col-2  flex-column flex-shrink-0 p-3 text-white ' style={{backgroundColor: '#121E2D',}} >
            <SideBar/>
        </div>
<div className='col-8 ' >
            <SirketUI/>
        </div>
*/
export default App;
