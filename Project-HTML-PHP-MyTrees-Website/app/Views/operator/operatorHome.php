<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
<link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet">

<main class="ml-64 mt-16 p-4 bg-gray-100 min-h-screen">
    <!-- Sección de bienvenida del panel de administración -->
    <div class="bg-gradient-to-r from-blue-500 to-indigo-500 shadow-lg rounded-lg p-6 mb-8 text-white">
        <h1 class="text-4xl font-bold text-center mb-4 flex items-center justify-center">
            <span>🎉</span> ¡Bienvenido/a, <?= htmlspecialchars($username, ENT_QUOTES, 'UTF-8'); ?>!
        </h1>
        <p class="text-lg text-center">
            Accede a información detallada y gestiona recursos de manera eficiente. ¡Tu rol es vital para el éxito!
        </p>
    </div>

    <!-- Sección con diseño flexible (responsivo) para gráficos -->
    <div class="flex flex-col lg:flex-row gap-8">
        <!-- Gráfico que muestra la distribución de amigos por género -->
        <div class="bg-white shadow-xl rounded-lg p-6 w-full lg:w-1/2 hover:shadow-2xl transition-shadow duration-300">
            <h2 class="text-2xl font-bold mb-4 text-center text-indigo-600">👥 Distribución por Género</h2>
            <p class="text-gray-600 mb-6 text-center">
                Un desglose de los amigos registrados por género para obtener mejores perspectivas de la comunidad.
            </p>
            <div class="flex flex-col items-center">
                <canvas id="genderChart" class="w-full h-60"></canvas>
                <div class="mt-6 bg-gray-100 p-4 rounded-md w-full text-gray-700">
                    <h3 class="text-lg font-bold text-center">Detalles</h3>
                    <ul class="mt-4 flex justify-around">
                        <li><strong>Mujeres:</strong> <?= $genders['F']; ?></li>
                        <li><strong>Hombres:</strong> <?= $genders['M']; ?></li>
                        <li><strong>Otro:</strong> <?= $genders['O']; ?></li>
                    </ul>
                </div>
            </div>
        </div>

        <!-- Gráfico para comparar árboles disponibles -->
        <div class="bg-white shadow-xl rounded-lg p-6 w-full lg:w-1/2 hover:shadow-2xl transition-shadow duration-300">
            <h2 class="text-2xl font-bold mb-4 text-center text-green-600">🌳 Árboles Disponibles</h2>
            <p class="text-gray-600 mb-6 text-center">
                Monitorea el inventario y evalúa la popularidad de las ofertas de árboles.
            </p>
            <canvas id="treesComparisonChart" class="w-full h-60"></canvas>
        </div>
    </div>
</main>


<!-- Script to create the bar chart for comparing available and sold trees -->
<script>
// Assigns the PHP values to JavaScript variables
const availableTreesCount = <?= $availableTreesCount; ?>;

// Gets the context for the bar chart canvas
const ctxComparison = document.getElementById('treesComparisonChart').getContext('2d');

// Creates the bar chart using Chart.js
const treesComparisonChart = new Chart(ctxComparison, {
    type: 'bar', // Specifies that the chart is a bar chart
    data: {
        labels: ['Trees'], // Labels for the X-axis
        datasets: [
            {
                label: 'Available Trees', // Label for the dataset
                data: [availableTreesCount], // Data for available trees
                backgroundColor: 'rgba(0, 255, 0, 0.5)', // Background color for the bars
                borderColor: 'rgba(0, 255, 0, 1)', // Border color for the bars
                borderWidth: 2 // Border width
            }
        ]
    },
    options: {
        responsive: true, // Makes the chart responsive
        plugins: {
            legend: {
                position: 'top', // Position of the legend
            },
            title: {
                display: true, // Display the title
                text: 'Comparison of Available Trees' // Title of the chart
            }
        },
        scales: {
            y: {
                beginAtZero: true, // Ensures that the Y-axis starts at zero
            }
        }
    }
});
</script>

<!-- Script to create the pie chart for the distribution of friends by gender -->
<script>
// Assigns the gender distribution data to JavaScript variables
const genders = {
    female: <?= $genders['F']; ?>,
    male: <?= $genders['M']; ?>,
    other: <?= $genders['O']; ?>
};

// Gets the context for the pie chart canvas
const ctx = document.getElementById('genderChart').getContext('2d');

// Creates the pie chart using Chart.js
const genderChart = new Chart(ctx, {
    type: 'pie', // Specifies that the chart is a pie chart
    data: {
        labels: ['Female', 'Male', 'Other'], // Labels for the gender categories
        datasets: [{
            label: 'Number of Registered Friends', // Label for the dataset
            data: [genders.female, genders.male, genders.other], // Data for each gender category
            backgroundColor: [
                'rgba(255, 0, 0, 0.8)', // Red color for female
                'rgba(0, 0, 255, 0.8)', // Blue color for male
                'rgba(0, 255, 0, 0.8)'  // Green color for other
            ],
            borderColor: [
                'rgba(255, 0, 0, 1)', // Red border for female
                'rgba(0, 0, 255, 1)', // Blue border for male
                'rgba(0, 255, 0, 1)'  // Green border for other
            ],
            borderWidth: 2 // Border width
        }]
    },
    options: {
        responsive: true, // Makes the chart responsive
        plugins: {
            legend: {
                position: 'top', // Position of the legend
            },
            title: {
                display: true, // Display the title
                text: 'Distribution of Friends by Gender' // Title of the chart
            }
        }
    }
});
</script>
