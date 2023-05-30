import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Login from './Pages/Login';


function App() {
  return (
    <div className="container p-4">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Login />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
