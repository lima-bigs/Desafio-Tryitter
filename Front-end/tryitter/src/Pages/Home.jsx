import React from 'react';
import Card from '../Components/Card';
import Button from '../Components/Button';

function Home() {
  return (
    <div>
      <div>
        Botão para inserir novo post
        <Button>Novo Post</Button>
      </div>
      <div>
        <Card />
      </div>
    </div>
  );
}

export default Home;
