import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";

const monsterApiUrl = 'http://localhost:5051';

export default function Monster(props) {
    let { monsterId } = useParams();
    const [monster, setMonster] = useState(null);

    if (props.id != null){
        monsterId = props.id;
    }

    useEffect( () => {
        fetch(monsterApiUrl + "/Monster/" + monsterId)
        .then(res => res.json())
        .then((data) => {
            setMonster(data)
        });
    }, []);

    if(monster != null) {
        return(
            <div className="card mb-3" style={{ maxWidth: 540}} >
                <div className="row g-0">
                    <div className="col-md-4">
                    <img src={{}} className="img-fluid rounded-start" alt="Picture of the current monster" />
                    </div>
                    <div className="col-md-8">
                    <div className="card-body">
                        <h5 className="card-title">Name: {monster.name}</h5>
                        <h6 className="card-subtitle mb-2 text-body-secondary">Rank: {monster.rank}</h6>
                        <h6 className="card-subtitle mb-2 text-body-secondary">Game ID: {monster.gameID}</h6>
                        <h6 className="card-subtitle mb-2 text-body-secondary">Family: {monster.family}</h6>
                        <p className="card-text">{monster.details}</p>
                        {/* <p className="card-text"><small className="text-body-secondary">Last updated 3 mins ago</small></p> */}
                    </div>
                    </div>
                </div>
            </div>
        );
    } else {
        return (
            <p>Loading monster data...</p>
        );
    }
}