import { useEffect, useState } from "react";
import Monster from "./Monster";

export default function Monsters() {
    const [monsterList, setMonsterList] = useState(null); 
    const [errorMessage, setErrorMessage] = useState(null);
    
    useEffect( () => {
        const fetchData = async () => {
            try {
                const res = await fetch("http://localhost:5051/Monster");

                if(!res.ok){
                    throw new Error("Cannot reach monster API");
                }

                const resToJson = await res.json();
                setMonsterList(resToJson);
            } catch(error) {
                setErrorMessage(error.message);
            }
        };

        fetchData();
    }, []);

    return(
        <>
            <h1>And there, a complete list of monsters!</h1>
            <div>
                { errorMessage && 
                    <p>The application encountered an error: {errorMessage} </p> }
                    
                { monsterList && 
                    monsterList.map(data => (
                        <Monster id={data.monsterId} />
                    ))
                }
            </div>
        </>
    );
}