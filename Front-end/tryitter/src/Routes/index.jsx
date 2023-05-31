import React from 'react';
import { Route, Routes } from 'react-router-dom';
import Login from '../Pages/Login';
import Cadastro from '../Pages/Cadastro';

function Routers() {
  return (
    <Routes>
      <Route path="/" element={<Login />} />
      <Route path="/cadastro" element={<Cadastro />} />
    </Routes>
  );
}

export default Routers;
