import React, { useState, useEffect } from 'react';
import Card from '../Components/Card';
import Button from '../Components/Button';
import Input from '../Components/Input';
import Modal from '../Components/Modal';
import { PostsUser } from '../Services/Request';

function Home() {
  const [search, setSearch] = useState('');
  const [data, SetData] = useState('');
  const [openModal, setOpenModal] = useState(false);
  const id = 1;

  const handleClickAdd = () => {
    console.log('Adicionar novo post');
    setOpenModal(true);
  };

  const handleClickSeach = () => {
    console.log('pesquisar');
  };

  const api = async () => {
    const posts = await PostsUser('/post/user/', id);
    SetData(posts);
  };

  useEffect(() => {
    api();
  }, []);

  return (
    <div className="mt-3">
      <div className="d-flex justify-content-between">
        <div>
          logo
        </div>
        <Button click={handleClickAdd} sty="fw-bold">Add Post</Button>
        <Modal open={openModal} onClose={() => setOpenModal(false)} />
      </div>
      <div>
        <div className="d-flex flex-row mb-3">
          <Input
            type="text"
            name="Pesquisar"
            handleChange={(e) => setSearch(e.target.value)}
            value={search}
          />
          <Button click={handleClickSeach} sty="ms-1 fw-bold">Pesquisar</Button>
        </div>
        <main>
          {/* Realizar o map para percorrer a lista e mandar para o card */}
          {
            console.log(data)
            // data.map((item) => <Card item={item} />)
          }
          <Card item="" />
        </main>
      </div>
    </div>
  );
}

export default Home;
