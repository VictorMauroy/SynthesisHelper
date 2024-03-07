import './App.css';
import {BrowserRouter as Router, Route, Routes } from "react-router-dom";
import HomePage from './views/HomePage.js';

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={<HomePage />} />
      </Routes>
    </Router>
  );
}

export default App;
