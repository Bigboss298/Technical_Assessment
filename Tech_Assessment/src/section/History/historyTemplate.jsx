

export default function HistoryTemplate({ data }) {
    if (!data) return <h1>No history yet</h1>;
    const { searchParam, timeStamp } = data;

    return (
        <div className="">
            <div className="history">
                <p>{searchParam}</p>
                <p>{timeStamp}</p>
            </div>
            <hr className="hr" />
        </div>
    )
}