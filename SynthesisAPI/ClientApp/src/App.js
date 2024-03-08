import './App.css';
import {BrowserRouter as Router, Route, Routes } from "react-router-dom";
import HomePage from './views/HomePage.js';
import Monster from './views/Monster.js';
import Monsters from './views/Monsters.js';
import NotFound from './views/NotFound.js';

const monsterApiUrl = 'http://localhost:3000';

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={ <HomePage /> } />

        <Route path='monsters' element= { <Monsters /> } >
          <Route 
            path=':monsterId' 
            element={ <Monster /> } 
            loader={async ({ params }) => {
              console.log(params.monsterId);
              return fetch(
                monsterApiUrl + `/Monster/${params.monsterId}.json`
              );
            }}
          />
        </Route>

        {/* <Route path="*" element={ <NotFound /> } /> */}
      </Routes>
    </Router>
  );
}

export default App;
