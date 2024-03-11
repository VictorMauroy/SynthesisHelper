import { useEffect, useState } from "react";
import Monster from "./Monster";

export default function Monsters() {
    const [monsterList, setMonsterList] = useState(null); 
    
    useEffect( () => {
        fetch("http://localhost:5051/Monster")
        .then(res => res.json())
        .then((data) => {
            setMonsterList(data)
        });
    }, []);

    console.log(monsterList + " are the data sended");

    return(
        <>
            <h1>And there, a complete list of monsters!</h1>
            <div>
                { monsterList && 
                    monsterList.map(data => (
                        <Monster id={data.monsterId} />
                    ))
                }
            </div>
        </>
    );
}