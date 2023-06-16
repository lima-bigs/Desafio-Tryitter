import React, { useState, useEffect } from 'react';
import PropTypes from 'prop-types';
// import { useNavigate } from 'react-router-dom';
import { Post } from '../Services/Request';
import Button from './Button';
import Input from './Input';

function Modal({ open, onClose }) {
  if (!open) return null;

  // const history = useNavigate();
  const [content, setContent] = useState('');
  const [image, setImage] = useState('');
  const [user, setUser] = useState('');

  const handleClick = async () => {
    try {
      const { userId, token } = user;
      const body = { content, image, userId };
      await Post('/post', body, `Bearer ${token}`);
    } catch (error) {
      console.log(error);
    }
  };

  const converterImagem = (e) => {
    console.log('112');
    const data = new FileReader();
    data.addEventListener('load', () => {
      setImage(data.result);
    });
    data.readAsDataURL(e.target.files[0]);
    console.log(image);
  };

  useEffect(() => {
    const login = JSON.parse(localStorage.getItem('user'));
    setUser(login);
  }, []);

  return (
    <div className="modalContainer p-3 rounded position-absolute top-50 start-50 translate-middle">
      <div className="text-end">
        <Button click={onClose}>X</Button>
      </div>
      <div className="text-center">
        <h3>Criar um novo Post</h3>
      </div>
      <div className="bt-3">
        <input type="file" id="load" onChange={converterImagem} />
        <Input
          type="text"
          name="Texto"
          handleChange={(e) => setContent(e.target.value)}
          value={content}
        />
        <div className="text-end">
          <Button click={handleClick}>Salvar</Button>
        </div>
      </div>
    </div>
  );
}

Modal.propTypes = {
  open: PropTypes.bool.isRequired,
  onClose: PropTypes.func.isRequired,
};

export default Modal;
