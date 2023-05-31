import React from 'react';
import PropTypes from 'prop-types';

function Button({
  children, click, sty, dataTestId,
}) {
  return (
    <button
      type="button"
      className={`btn btn-danger mt-3 ${sty}`}
      onClick={click}
      data-testid={dataTestId}
    >
      {children}
    </button>
  );
}

Button.defaultProps = {
  sty: '',
  children: '',
  click: () => {},
  dataTestId: '',
};
Button.propTypes = {
  children: PropTypes.oneOfType([
    PropTypes.object,
    PropTypes.string,
  ]),
  click: PropTypes.func,
  sty: PropTypes.string,
  dataTestId: PropTypes.string,
};

export default Button;
