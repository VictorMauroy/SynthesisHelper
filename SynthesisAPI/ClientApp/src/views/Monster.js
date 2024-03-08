import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";

const monsterApiUrl = 'http://localhost:5051';

export default function Monster() {
    let { monsterId } = useParams();
    const [monster, setMonster] = useState(null);

    useEffect( () => {
        fetch(monsterApiUrl + "/Monster/" + monsterId)
        .then(res => res.json())
        .then((data) => {
            setMonster(data)
        });
    }, []);

    if(monster != null) {
        return(
            <div className="card">
                <div className="card-body">
                    <h5 className="card-title">Name: {monster.name}</h5>
                    <h6 className="card-subtitle mb-2 text-body-secondary">Rank: {monster.rank}</h6>
                    <h6 className="card-subtitle mb-2 text-body-secondary">Game ID: {monster.gameID}</h6>
                    <h6 className="card-subtitle mb-2 text-body-secondary">Family: {monster.family}</h6>
                    <p className="card-text">{monster.details}</p>
                </div>
            </div>
        );
    } else {
        return (
            <p>Loading monster data...</p>
        );
    }
}