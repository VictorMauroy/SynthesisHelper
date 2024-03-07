import './App.css';
import {BrowserRouter as Router, Route, Routes } from "react-router-dom";
import HomePage from './views/HomePage.js';
import Monster from './views/Monster.js';

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={<HomePage />} />
        <Route path='/monster/:id' element={ <Monster />} />
      </Routes>
    </Router>
  );
}

export default App;
