import React, { useContext, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Button from '../Components/Button';
import Input from '../Components/Input';
import MyContext from '../MyContext/MyContext';
import {
  isValidEmail,
  isValidPassword,
  isValidName,
} from '../Utils/Validacao';

function Cadastro() {
  const history = useNavigate();
  const [nome, setNome] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [modulo, setModulo] = useState('');
  const [status, setStatus] = useState('');

  const [msgErro, setMsgErro] = useState(false);
  const { MIN_PASSWORD_LANGTH } = useContext(MyContext);

  const handleClick = () => {
    if (
      isValidEmail(email)
      && isValidPassword(password, MIN_PASSWORD_LANGTH)
      && isValidName(nome)
    ) {
      console.log('ok');
      setMsgErro(false);
      history('/home');
    } else {
      setMsgErro(true);
    }
  };

  return (
    <main className="container-login container position-absolute top-50 start-50 translate-middle">
      <div className="width-input-cadastro">
        <h1 className="txt-login">Cadastro</h1>
        <section>
          <Input
            type="text"
            name="Nome"
            handleChange={(e) => setNome(e.target.value)}
            value={nome}
          />

          <Input
            type="email"
            name="E-mail"
            handleChange={(e) => setEmail(e.target.value)}
            value={email}
          />

          <Input
            type="password"
            name="Password"
            handleChange={(e) => setPassword(e.target.value)}
            value={password}
          />
          <p className="min-password text-end">
            {`Caracteres minimo para senha: ${MIN_PASSWORD_LANGTH}`}
          </p>

          <Input
            type="text"
            name="Modulo Atual"
            sty="adjustment-height"
            handleChange={(e) => setModulo(e.target.value)}
            value={modulo}
          />

          <select className="form-select mt-3 ver" value={status} onChange={(e) => setStatus(e.target.value)}>
            <option value="andamento">Em andamento</option>
            <option value="finalizado">Finalizado</option>
          </select>
          {
            msgErro
              && <p className="text-danger">Dados incorreto! Verificar todos os campos.</p>
            }
        </section>
        <Button click={handleClick} sty="w-100">Cadastrar</Button>
        <Button click={() => history('/')} sty="w-100">Voltar</Button>
      </div>
    </main>
  );
}

export default Cadastro;
