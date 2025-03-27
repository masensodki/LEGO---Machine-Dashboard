import { queryOptions } from "@tanstack/react-query";

const url = import.meta.env.VITE_APP_API_ENDPOINT;

export default function createMachineQueryOptions() {
  return queryOptions({
    queryKey: ["machines"],
    queryFn: getMachines,
  });
}

const getMachines = async (): Promise<Machine[]> => {
  const response = await fetch(`${url}/api/machine`, {
    method: "GET",
    mode: "cors",
    headers: {
      "Content-Type": "application/json",
    },
  });

  const json = await response.json();
  return json;
};

export type Machine = {
  id: string;
  name: string;
  state: string;
  lastUpdated?: string;
  currentJobId?: string;
};
