import { useSuspenseQuery } from "@tanstack/react-query";
import createMachineQueryOptions from "../../queryOptions/createMachineQueryOptions";
import "./table.scss";

export default function Table() {
  const { data } = useSuspenseQuery(createMachineQueryOptions());

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
              <td>{machine.state}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
