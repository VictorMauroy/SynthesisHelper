
export default function RankSelector(props) {
    const previousRank = props.rank;

    const RankNames = [
        "G",
        "F",
        "E",
        "D",
        "C",
        "B",
        "A",
        "S",
        "X"
    ];

    return(
        <div className="form-group">
            <label className="form-label">Rank</label>
            <select name="rankSelect" className="form-select" defaultValue={previousRank}>
                {
                    RankNames.map(rank => (
                        rank === previousRank ?
                            <option key={rank} value={rank}>{rank}</option> :
                            <option key={rank} value={rank}>{rank}</option>
                    ))
                }
            </select>
        </div>
    );
}