import { Machine } from "../../queries/createMachineQuery";
import "./table.scss";

interface TableProps {
  data: Machine[];
}

export default function Table({ data }: TableProps) {

  if (!data || data.length === 0) {
    return <div className="container">No data available</div>;
  }

  return (
    <div className="container">
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Status</th>
          </tr>
        </thead>
        <tbody>
          {data.map((machine) => (
            <tr key={machine.id}>
              <td>{machine.id}</td>
              <td>{machine.name}</td>
              <td>
                <span
                  className={`state-button ${String(machine.state).toLowerCase()}`}
                />
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
