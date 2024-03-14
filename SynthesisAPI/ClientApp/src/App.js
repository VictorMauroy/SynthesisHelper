import './App.css';
import {BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Home from './views/Home.js';
import Monster from './components/Monster.js';
import Monsters from './views/Monster/Monsters.js';
import NotFound from './views/NotFound.js';
import EditMonster from './views/Monster/EditMonster.js';

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={ <Home /> } />

        <Route path='monsters' element= { <Monsters /> } />
        <Route path='monster/:monsterId' element={ <Monster /> } />
        <Route path='editMonster/:monsterId' element={ <EditMonster /> } />

        <Route path="*" element={ <NotFound /> } />
      </Routes>
    </Router>
  );
}

export default App;
