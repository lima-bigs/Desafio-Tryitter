import Routes from './Routes';
import MyContext from './MyContext/MyContext';
import { useState } from 'react';
import { BrowserRouter } from 'react-router-dom';

function App() {
  const MIN_PASSWORD_LANGTH = 6;
  const [loading, setLoading] = useState(false);


  const contextValue = {
    MIN_PASSWORD_LANGTH,
    loading, setLoading,
  };

  return (
    <MyContext.Provider value={contextValue}>
      <div>
        <BrowserRouter>
          <Routes />
        </BrowserRouter>
      </div>
    </MyContext.Provider>
  );
}

export default App;
