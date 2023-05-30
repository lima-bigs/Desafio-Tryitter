import React, { useState } from 'react';
import Input from '../Components/Input';
import Button from '../Components/Button';

function Login() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log('submeter');
  };

  return (
    <div>
      <div>
        logo
      </div>
      <div>
        <h1>Realizar login</h1>
        <form onSubmit={handleSubmit}>
          <Input
            type="email"
            name="email"
            value={email}
            placeholder="E-mail"
            onChange={(e) => setEmail(e.target.value)}
          />
          <Input
            type="password"
            name="password"
            value={password}
            placeholder="E-mail"
            onChange={(e) => setPassword(e.target.value)}
          />

          <Button>Entrar</Button>
        </form>
      </div>
    </div>
  );
}

export default Login;
