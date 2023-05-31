import React, { useContext, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Input from '../Components/Input';
import Button from '../Components/Button';
import MyContext from '../MyContext/MyContext';
import { isValidEmail, isValidPassword } from '../Utils/Validacao';
import '../App.css';

function Login() {
  const history = useNavigate();
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [msgErro, setMsgErro] = useState(false);
  const { MIN_PASSWORD_LANGTH } = useContext(MyContext);

  const handleClick = () => {
    if (isValidEmail(email) && isValidPassword(password, MIN_PASSWORD_LANGTH)) {
      setEmail('');
      setPassword('');
      history('/home');
    } else {
      setMsgErro(true);
    }
  };

  return (
    <main className="container-login position-absolute top-50 start-50 translate-middle border border-dark p-3">
      <h1 className="txt-login pt-2">Login</h1>
      <section className="width-input-login">
        <Input
          type="text"
          name="email"
          handleChange={(e) => setEmail(e.target.value)}
          value={email}
        />
        <Input
          type="password"
          name="password"
          handleChange={(e) => setPassword(e.target.value)}
          value={password}
        />
        <p className="min-password text-end">
          {`Caracteres minimo para senha: ${MIN_PASSWORD_LANGTH}`}
        </p>
        <Button click={handleClick} sty="w-100" dataTestId="btn-entrar">Entrar</Button>
        { msgErro && <p className="text-danger">E-mail ou senha incorreto!</p> }
      </section>
      <p className="txt-cadastro">
        Não possui cadastro?
      </p>
      <Button click={() => history('/cadastro')} sty="cadastrar w-100"> Cadastrar</Button>
    </main>
  );
}

export default Login;
