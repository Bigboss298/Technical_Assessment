
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

    if (loading) return (
        <div className='historyTemplate'>
            <h1>loading...</h1>
        </div>
    )

    if (!data || data.length === 0) return (
        <div className='historyTemplate'>
            <h1>No query yet</h1>
        </div>
    )

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
