import React from 'react'

export default function PopupSirketHata() {
  return (
    <div
        className="modal fade"
        id="exampleModal"
        tabIndex={-1}
        aria-labelledby="exampleModalLabel"
        aria-hidden="true"
      >
        <div className="modal-dialog">
          <div className="modal-content">
            <div className="modal-header">
              <h5 className="modal-title" id="exampleModalLabel">
                Modal title
              </h5>
              <button
                type="button"
                className="btn-close"
                data-bs-dismiss="modal"
                aria-label="Close"
              />
            </div>
            <div className="modal-body">değişiklikler kaydedilmedi </div>
            <div className="modal-footer">
              <button type="button" className="btn btn-primary">
                Kaydet
              </button>
            </div>
          </div>
        </div>
      </div>
  )
}
