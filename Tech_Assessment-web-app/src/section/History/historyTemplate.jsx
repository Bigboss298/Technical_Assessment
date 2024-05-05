

export default function HistoryTemplate({ data }) {
    if (!data) return <h1>No history yet</h1>;
    const { searchParam, timeStamp } = data;

var date = new Date(timeStamp);

var year = date.getFullYear();
var month = String(date.getMonth() + 1).padStart(2, '0');
var day = String(date.getDate()).padStart(2, '0');
var hours = String(date.getHours()).padStart(2, '0');
var minutes = String(date.getMinutes()).padStart(2, '0');

var newDate = year + "/" + month + "/" + day + " " + hours + ":" + minutes;


    return (
        <div className="">
            <div className="history">
                <p>{searchParam}</p>
                <p>{newDate}</p>
            </div>
            <hr className="hr" />
        </div>
    )
}