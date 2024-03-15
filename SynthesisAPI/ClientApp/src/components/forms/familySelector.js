
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
        <div className="form-group">
            <label className="form-label">Family</label>
            <select className="form-select" defaultValue={previousFamily}>
                {
                    familyNames.map(family => (
                        family === previousFamily ?
                            <option key={family} value={family}>{family}</option> :
                            <option key={family} value={family}>{family}</option>
                    ))
                }
            </select>
        </div>
    );
}