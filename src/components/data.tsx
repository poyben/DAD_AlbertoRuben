import { Chart as ChartJS, ChartData } from 'chart.js/auto';
import { Line } from 'react-chartjs-2';

import { CategoryScale, LinearScale, PointElement, LineElement, Title, Tooltip, Legend } from 'chart.js';

// Registra las escalas y elementos necesarios
ChartJS.register(CategoryScale, LinearScale, PointElement, LineElement, Title, Tooltip, Legend);

// datos de ejemplo para el gráfico
const data: ChartData<"line", number[], string> = {    labels: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio'],
    datasets: [
      {
        label: 'My First dataset',
        fill: false,
        //lineTension: 0.1,
        backgroundColor: 'rgba(75,192,192,0.4)',
        borderColor: 'rgba(75,192,192,1)',
        borderCapStyle: 'butt', // Make sure this is one of 'butt', 'round', 'square'
        borderDash: [],
        borderDashOffset: 0.0,
        borderJoinStyle: 'miter',
        pointBorderColor: 'rgba(75,192,192,1)',
        pointBackgroundColor: '#fff',
        pointBorderWidth: 1,
        pointHoverRadius: 5,
        pointHoverBackgroundColor: 'rgba(75,192,192,1)',
        pointHoverBorderColor: 'rgba(220,220,220,1)',
        pointHoverBorderWidth: 2,
        pointRadius: 1,
        pointHitRadius: 10,
        data: [65, 59, 80, 81, 56, 55, 40]
      }
    ]
  };

export function MyChart() {
    return <Line data={data as ChartData<"line", number[], string>} />;}