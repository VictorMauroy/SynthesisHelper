import './App.css';
import {BrowserRouter as Router, Route, Routes } from "react-router-dom";
import HomePage from './views/HomePage.js';
import Monster from './views/Monster.js';
import Monsters from './views/Monsters.js';
import NotFound from './views/NotFound.js';

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={ <HomePage /> } />

        <Route path='monsters' element= { <Monsters /> } />
        <Route path='monster/:monsterId' element={ <Monster /> } />

        <Route path="*" element={ <NotFound /> } />
      </Routes>
    </Router>
  );
}

export default App;
