import React, { Component } from 'react'
import UserConsumer from '../Context'

export default class AnaSayfa extends Component {
  render() {
    return (
      <UserConsumer>
        {
          value=>{
            const {ogrenci}=value;
            return(
              <div className='col' > 
                <br/>
                <h3  >Duyurular</h3>
                <hr/>
              </div>
            )
          }
        }
      </UserConsumer>
      
    )
  }
}
