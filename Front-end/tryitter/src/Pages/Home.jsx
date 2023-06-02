import React, { useState } from 'react';
import Card from '../Components/Card';
import Button from '../Components/Button';
import Input from '../Components/Input';

function Home() {
  const [search, setSearch] = useState('');

  const handleClickAdd = () => {
    console.log('Adicionar novo post');
  };

  const handleClickSeach = () => {
    console.log('pesquisar');
  };

  return (
    <div className="mt-3">
      <div className="d-flex justify-content-between">
        <div>
          logo
        </div>
        <Button click={handleClickAdd} sty="fw-bold">Add Post</Button>
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
          <Card item="" />
        </main>
      </div>
    </div>
  );
}

export default Home;
