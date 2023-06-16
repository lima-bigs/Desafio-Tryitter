import React from 'react';
import PropTypes from 'prop-types';

function Card({ item }) {
  return (
    <article className="shadow m-2 bg-body card text-center col-4">
      <div className="card text-bg-dark">
        <img src={item.image} className="card-img" alt="..." />
      </div>
      <p className="mt-3">{item.content}</p>
      <div className="d-flex justify-content-around mb-3">
        <div>
          editar
        </div>
        <div>
          excluir
        </div>
      </div>
    </article>
  );
}

Card.propTypes = {
  item: PropTypes.shape({
    postId: PropTypes.number.isRequired,
    content: PropTypes.string.isRequired,
    image: PropTypes.string.isRequired,
    userId: PropTypes.number.isRequired,
  }).isRequired,
};

export default Card;
