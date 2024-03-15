
export default function FamilySelector(props) {
    const previousFamily = props.family;

    const familyNames = [
        "Bird",
        "Demon",
        "Dragon",
        "Humanoid",
        "Plant",
        "Slime",
        "Undead",
        "Unknow"
    ];

    return(
        <>
            <label for="MonsterFamily" className="form-label">Family</label>
            <select name="MonsterFamily" className="form-select">
                {
                    familyNames.map(family => (
                        family === previousFamily ?
                            <option selected>{family}</option> :
                            <option>{family}</option>
                    ))
                }
            </select>
        </>
    );
}