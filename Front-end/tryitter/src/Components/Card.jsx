import React from 'react';
import PropTypes from 'prop-types';

function Card({ item }) {
  return (
    <article className="shadow m-2 bg-body card text-center col-4">
      <div className="card text-bg-dark">
        <img src="https://media.istockphoto.com/id/1346613110/pt/foto/tropeiro-beans-typical-brazilian-food.jpg?s=612x612&w=0&k=20&c=cUe09FVI2-0knJ1TRrXa8H9Ogvut32v_jYLLx-pmNhc=" className="card-img" alt="..." />
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
