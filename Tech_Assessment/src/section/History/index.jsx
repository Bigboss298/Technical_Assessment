
import HistoryTemplate from './historyTemplate';
import { useSearchs } from '../../Zustand/searchSlice';
import { useEffect } from 'react';

export default function HistoryPage() {
    const { get, query, fetchQuery } = useSearchs();

    useEffect(() => {
        fetchQuery();
    }, []);

    const { data } = query;
    const { loading } = get;

    if (loading) return <h1>Loading...</h1>;

    if (!data) return <h1>No query yet</h1>

    return (
        <div className='historyTemplate'>
            <h1>5 recent searches</h1>
            <div className='historyTemplate1'>
                <div className='historyTemplate2'>
                    {data.map((history, index) => (
                        <HistoryTemplate key={index} data={history} />
                    ))}
                </div>
            </div>
        </div>
    );
}
