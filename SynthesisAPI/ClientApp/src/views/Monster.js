import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";

const monsterApiUrl = 'http://localhost:5051';

export default function Monster() {
    let { monsterId } = useParams();
    const [monster, setMonster] = useState(null);

    console.log(monster);

    useEffect( () => {
        fetch("http://localhost:5051/Monster/" + monsterId)
        .then(res => res.json())
        .then((data) => {
            setMonster(data)
        });
    }, []);

    return(
        <>
            <p> 
                There is a monster here! <br />
                Its name is {monster && monster.name}
            </p>
        </>
    );
}