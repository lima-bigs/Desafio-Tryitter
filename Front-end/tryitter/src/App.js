import Routes from './Routes';
import MyContext from './MyContext/MyContext';
import { useState } from 'react';

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
        <HashRouter>
          <Routes />
        </HashRouter>
      </div>
    </MyContext.Provider>
  );
}

export default App;
