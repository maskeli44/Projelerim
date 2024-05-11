import React from 'react'

export default function Popup (props) {
    const {title,children,openPopup,setOpenPopup}=props;

  
    return (
      <dialog open={openPopup}>
       <dialogTitle>
        <div>ogrenci bilgisi</div>
       </dialogTitle>
       <dialogContent>
        {children}
       </dialogContent>
      </dialog>
    )
  
}  
