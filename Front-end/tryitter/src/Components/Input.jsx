import React from 'react';
import PropTypes from 'prop-types';

function Input({
  type, name, value, handleChange, sty,
}) {
  return (
    <label htmlFor={name} className="input-group mt-3">
      <input
        type={type}
        id={name}
        name={name}
        data-testid={name}
        onChange={handleChange}
        value={value}
        className={`form-control ${sty}`}
        placeholder={name}
      />
    </label>
  );
}

Input.defaultProps = { value: '', sty: '' };
Input.propTypes = {
  type: PropTypes.string.isRequired,
  name: PropTypes.string.isRequired,
  value: PropTypes.string,
  handleChange: PropTypes.func.isRequired,
  sty: PropTypes.string,
};

export default Input;
