import Table from "./components/Table/Table";
import Header from "./components/Header/Header";
import { useQuery } from "@tanstack/react-query";
import createMachineQueryOptions from "./queryOptions/createMachineQueryOptions";

const App = () => {
  const { data = [], isLoading } = useQuery(createMachineQueryOptions());

  return (
    <div className="app-container">
      <Header />
      <main>
        {isLoading ? <div>Loading...</div> : <Table data={data} />}
      </main>
    </div>
  );
};

export default App;
