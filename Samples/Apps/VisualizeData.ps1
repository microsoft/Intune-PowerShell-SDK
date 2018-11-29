[CmdletBinding()]
param(
    [ValidateNotNullOrEmpty()]
    [string]$Title,

    [ValidateSet('Pie', 'Bar', 'Column')]
    [string]$ChartType,

    [string]$XLabel,

    [string]$YLabel,

    [ValidateNotNull()]
    [object[]]$XValues,

    [ValidateNotNull()]
    [object[]]$YValues
)

if ($XValues.Length -ne $YValues.Length) {
    throw "Number of X ($($XValues.Length)) values must equal number of Y values ($($YValues.Length))"
}

[Reflection.Assembly]::LoadWithPartialName("System.Windows.Forms") | Out-Null
[Reflection.Assembly]::LoadWithPartialName("System.Windows.Forms.DataVisualization") | Out-Null

# Create a chart object
$chart = New-Object System.Windows.Forms.DataVisualization.Charting.Chart
$chart.Width = 500
$chart.Height = 500
$chart.Left = 40
$chart.Top = 30

# Create a ChartArea to draw on and add it to chart
$chartArea = New-Object System.Windows.Forms.DataVisualization.Charting.ChartArea
$chart.ChartAreas.Add($chartArea)

# Add data to the chart
$series = New-Object System.Windows.Forms.DataVisualization.Charting.Series -ArgumentList 'Data'
$series.Points.DataBindXY($XValues, $YValues)

# Set specialized chart options based on chart type
switch ($ChartType) {
    'Pie' {
        $series.ChartType = [System.Windows.Forms.DataVisualization.Charting.SeriesChartType]::Pie
        $series["PieLabelStyle"] = "Outside"
        $series["PieLineColor"] = "Black"
        $series["PieDrawingStyle"] = "Concave"
        ($series.Points.FindMaxByValue())["Exploded"] = $true
    }

    'Bar' {
        $series.ChartType = [System.Windows.Forms.DataVisualization.Charting.SeriesChartType]::Bar
        $series['DrawingStyle'] = 'Cylinder'
    }

    'Column' {
        $series.ChartType = [System.Windows.Forms.DataVisualization.Charting.SeriesChartType]::Column
        $series['DrawingStyle'] = 'Cylinder'
    }

    default {
        throw "Unknown chart type '$ChartType'"
    }
}
$chart.BackColor = [System.Drawing.Color]::Transparent

# Add the labels
$chart.Titles.Add($Title) | Out-Null
$chartArea.AxisX.Title = $XLabel
$chartArea.AxisY.Title = $YLabel

# Display the chart on a form
$chart.Series.Add($series)
$chart.Anchor = [System.Windows.Forms.AnchorStyles]::Bottom `
           -bor [System.Windows.Forms.AnchorStyles]::Right `
           -bor [System.Windows.Forms.AnchorStyles]::Top `
           -bor [System.Windows.Forms.AnchorStyles]::Left
$form = New-Object Windows.Forms.Form
$form.Text = $Title
$form.Width = 600
$form.Height = 600
$form.controls.add($chart)
$form.Add_Shown({$form.Activate()})
$form.ShowDialog() | Out-Null