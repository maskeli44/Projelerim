import React from 'react';
import './App.css';
import AnaSayfa from './Components/AnaSayfa';
import Navbar from './Components/Navbar';
import PopupSirketKeyitOnay from './Components/PopupSirketKeyitOnay';
import SideBar from './Components/SideBar';
import SirketUI from './Components/SirketUI2';
import StajBilgiEkrani from './Components/StajBilgiEkrani';

class App extends React.Component {
  constructor(props){
    super(props);
    this.state={
      activePage:'AnaSayfa'
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
      <div className='row  ' style={{height:'100vh'}}>
        <SideBar handlePageChange={this.handlePageChange}/>
        {activePage=== 'AnaSayfa'&&<AnaSayfa handlePageChange={this.handlePageChange}/>}
        {activePage=== 'SirketUI'&&<SirketUI handlePageChange={this.handlePageChange}/>}
        {activePage=== 'StajBilgiEkrani'&&<StajBilgiEkrani handlePageChange={this.handlePageChange}/>}
        
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
