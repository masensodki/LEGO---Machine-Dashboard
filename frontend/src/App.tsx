import { Suspense } from "react";
import Table from "./components/Table/Table";
import Header from "./components/Header/Header";

function App() {
  return (
    <>
      <Header />
      <Suspense fallback={<div>Loading...</div>}>
        <Table />
      </Suspense>
    </>
  );
}

export default App;
