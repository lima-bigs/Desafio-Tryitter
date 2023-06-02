import React from 'react';
import PropTypes from 'prop-types';

function Card({ item }) {
  return (
    <article className="shadow m-2 bg-body card text-center">

      <div className="card text-bg-dark">
        <img src="https://media.istockphoto.com/id/1346613110/pt/foto/tropeiro-beans-typical-brazilian-food.jpg?s=612x612&w=0&k=20&c=cUe09FVI2-0knJ1TRrXa8H9Ogvut32v_jYLLx-pmNhc=" className="card-img" alt="..." />
        <div className="card-img-overlay">
          <h5 className="card-title">Card title</h5>
        </div>
      </div>
      <img src="" alt="" />
      <p>{item.title}</p>
      <p>texto dhisahdia disadhas dnasiidaos jdioasioda</p>
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
    id: PropTypes.string.isRequired,
    title: PropTypes.string.isRequired,
  }).isRequired,
};

export default Card;
