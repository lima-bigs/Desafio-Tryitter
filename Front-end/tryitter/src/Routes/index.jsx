import React from 'react';
import { Route, Routes } from 'react-router-dom';
import Login from '../Pages/Login';
import Cadastro from '../Pages/Cadastro';
import Loja from '../Pages/Loja';
import Detalhes from '../Components/Detalhes';

function Routers() {
  return (
    <Routes>
      <Route path="/" element={<Login />} />
      <Route path="/cadastro" element={<Cadastro />} />
      <Route path="/loja" element={<Loja />} />
      <Route path="/detalhes/:id" element={<Detalhes />} />
    </Routes>
  );
}

export default Routers;
