import React, { Component } from 'react'
import  'https://kit.fontawesome.com/bc71450b11.js'
import uniLogo from '../../images/uniLogo.gif'
 class SideBar extends Component {
    state={
        isVisible:[false,false],
        isArrowTurned : [false,false]
    }
    constructor (props){
        super(props);
        this.onClickEvent = this.onClickEvent.bind(this);
    }
    onClickEvent=(e)=>{

    }
    onStajEvent=(e)=>{
        this.setState({
            isVisible: [!this.state.isVisible[0]],
            isArrowTurned: [!this.state.isArrowTurned[0]]
        })
    }
    onYazEvent=(e)=>{
        this.setState({
            isVisible: [,!this.state.isVisible[1]],
            isArrowTurned: [,!this.state.isArrowTurned[1]]
        })
    }
  render() {
    const {isVisible}=this.state;
    const {isArrowTurned} = this.state;
    const props= this.props;
    
    return (
        <div className=' col-2  d-flex flex-column flex-shrink-0 p-0 text-white SideBar' style={{backgroundColor: '#121E2D',}} >
            <div className='row-auto'>
                <div className="container-fluid col">
                    <a className="navbar-brand" href="index" style={{color:'white'}}>
                        <img src={uniLogo} alt="" width="75px" height="75px" className="d-inline-block align-text-center"/>
                    
                    </a>
                    <hr/> 
                    <div>
                            <h6><a href='#' style={{color: 'white', textDecoration: 'none'}} onClick={(e)=>props.handlePageChange('AnaSayfa')}>Anasayfa</a></h6>
                    </div>
                    <div>
                        <div>
                            <h6 onClick={this.onStajEvent.bind(this)} >
                                {
                                   isArrowTurned[0] ? <i className='fa-solid fa-angle-down'/> : <i className='fa-solid fa-angle-up'/>
                                }
                                <a href='#' style={{color: 'white',textDecoration:'none' }}>Staj İşlemleri</a>
                            </h6>
                        </div>
                        {
                                    isVisible[0] ? 
                                    <ul>
                                        <li onClick={(e)=>props.handlePageChange('SirketUI')}><a href='#' style={{color: 'white',textDecoration:'none' }}>Şirket Listesi</a></li>
                                        <li onClick={(e)=>props.handlePageChange('StajBilgiEkrani')}><a  href='#' style={{color: 'white',textDecoration:'none' }}>Staj Listesi</a></li>
                                    </ul> : null
                        }
                    </div>
                    <div>
                        <div>
                            <h6 onClick={this.onYazEvent.bind(this)} >
                            {
                                   isArrowTurned[1] ? <i className='fa-solid fa-angle-down'/> : <i className='fa-solid fa-angle-up'/>
                            }
                            <a href='#' style={{color: 'white',textDecoration:'none' }}>Yaz Okulu İşlemleri</a>
                                
                            </h6>
                        </div>
                        {
                                    isVisible[1] ? 
                                    <ul>
                                        <li><a  href='#' style={{color: 'white',textDecoration:'none'  }}>dsmdsf</a></li>
                                        <li><a  href='#' style={{color: 'white',textDecoration:'none'  }}>fsdfagdf</a></li>
                                    </ul> : null
                        }
                    </div>
                   
                </div>
                
            </div>
        </div>   
      
    )
  }
}
/*

*/
export default SideBar;