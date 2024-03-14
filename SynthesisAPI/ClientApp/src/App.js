import './App.css';
import {BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Home from './views/Home.js';
import MonstersList from './components/MonstersList.js';
import NotFound from './views/NotFound.js';
import EditMonster from './views/Monster/EditMonster.js';
import MonsterDetails from './views/Monster/MonsterDetails.js';

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={ <Home /> } />

        <Route path='monsters' element= { <MonstersList /> } />
        <Route path='monster/:monsterId' element={ <MonsterDetails /> } />
        <Route path='editMonster/:monsterId' element={ <EditMonster /> } />

        <Route path="*" element={ <NotFound /> } />
      </Routes>
    </Router>
  );
}

export default App;
