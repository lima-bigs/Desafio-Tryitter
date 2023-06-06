import React from 'react';
import PropTypes from 'prop-types';
import Button from './Button';

function Modal({ open, onClose }) {
  if (!open) return null;
  return (
    <div className="modalContainer p-3">
      <div className="text-end">
        <Button click={onClose}>X</Button>
      </div>
      <div className="bt-3">
        hsuahsuahusa
        <p>hdaushduashda</p>
        <p>hdaushduashda</p>
        <p>hdaushduashda</p>
      </div>
    </div>
  );
}

Modal.propTypes = {
  open: PropTypes.bool.isRequired,
  onClose: PropTypes.func.isRequired,
};

export default Modal;
