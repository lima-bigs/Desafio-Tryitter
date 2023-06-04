import React from 'react';
import PropTypes from 'prop-types';
import Button from './Button';

function Modal({ open, onClose }) {
  if (!open) return null;
  return (
    <div className="">
      <div>
        hsuahsuahusa
        <p>hdaushduashda</p>
        <p>hdaushduashda</p>
        <p>hdaushduashda</p>
      </div>
      <div className="text-end border border-success modalContainer">
        <Button click={onClose}>X</Button>
      </div>
    </div>
  );
}

Modal.propTypes = {
  open: PropTypes.bool.isRequired,
  onClose: PropTypes.string.isRequired,
};

export default Modal;
