import { useState, useEffect } from "react";
import { Link, useParams } from "react-router-dom";

const monsterApiUrl = 'http://localhost:5051';

export default function MonsterCard(props) {
    let { monsterId } = useParams();
    const [monster, setMonster] = useState(null);
    const [errorMessage, setErrorMessage] = useState(null);

    if (props.id != null){
        monsterId = props.id;
    }

    useEffect( () => {
        const fetchData = async () => {
            try {
                const res = await fetch(monsterApiUrl + "/Monster/" + monsterId);

                if(!res.ok){
                    throw new Error("Cannot reach monster API");
                }

                const resToJson = await res.json();
                setMonster(resToJson);
            } catch(error) {
                setErrorMessage(error.message);
            }
        };

        fetchData();
    }, [monsterId]);

    if(monster != null) {
        return(
            <div className="card mb-3" style={{ maxWidth: 540}} >
                <Link className="row g-0" to={"monster/" + monsterId}>
                    <div className="col-md-4">
                    <img src={{}} className="img-fluid rounded-start" alt={ "Appearance of " + monster.name} />
                    </div>
                    <div className="col-md-8">
                        <div className="card-body">
                            <h5 className="card-title">Name: {monster.name}</h5>
                            <h6 className="card-subtitle mb-2 text-body-secondary">Rank: {monster.rank}</h6>
                        </div>
                    </div>
                </Link>
                {/* <div className="row g-0">
                </div> */}
            </div>
        );
    } else if(errorMessage != null){
        return <p>The application encountered an error: {errorMessage} </p>;
    } else {
        return (
            <p>Loading monster data...</p>
        );
    }
}